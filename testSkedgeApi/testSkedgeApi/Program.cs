using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;
using testSkedgeApi.Dtos;

namespace TestSkedgeApi;
static class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Welcome to test Skedge API project");
        // Connet to API and get Authentification Token
        Console.WriteLine("Initialization");
        var client = ConnectToApiIpAndPort("localhost:5000"); // Use the right url and port to your Skedge Server here
        SetAuthorisationHeaderIfNeeded(client);

        Console.WriteLine($"Authorization header: {client.DefaultRequestHeaders.Authorization}");

        if (client.DefaultRequestHeaders?.Authorization == null)
        {
            Console.WriteLine($"error in getting Authorization header");
            return;
        }
        // Test all API methode
        Console.WriteLine("*********** Test all API methods ***********");
        var lightOrganisms = await GetOrganisms(client);
        if(lightOrganisms.Count > 0)
        {
            Console.WriteLine("Light organism list");
            lightOrganisms.ForEach(org =>
            {
                Console.WriteLine($"Organism Name: {org.Name} | Id: {org.Id}");

            });

            var entitiesExample = await GetEntitiesByOrganism(lightOrganisms[0].Id, client);
            if(entitiesExample.Count > 0)
            {
                Console.WriteLine($"Light entities list for {lightOrganisms[0].Name}");
                entitiesExample.ForEach(entity =>
                {
                    Console.WriteLine($"Entity Name: {entity.Name} | Id: {entity.Id}");
                });

                var entityDetailsExample = await GetEntityDetail(lightOrganisms[0].Id, entitiesExample[0].Id, client);
                
                Console.WriteLine($"Entity details example for  {entityDetailsExample.Name}");
                var entityDetailsExampleType = entityDetailsExample.GetType();
                var entityDetailsExampleTypeProperties = entityDetailsExampleType.GetProperties();
                foreach (var property in entityDetailsExampleTypeProperties)
                {
                    var name = property.Name;
                    var value = property.GetValue(entityDetailsExample);
                    var valueString = value != null ? value.ToString() : "null";

                    Console.WriteLine($"{name}: {valueString}");
                }
            } else
            {
                Console.WriteLine($"No entities for organism {lightOrganisms[0].Name}");
            }
            

            var exercisesExample = await GetExercisesByOrganism(lightOrganisms[0].Id, client);
            Console.WriteLine($"exercise list for {lightOrganisms[0].Name}");
            exercisesExample.ForEach(exercise =>
            {
                Console.WriteLine($"exercise {exercise.Name} | {exercise.EntityComparaisonGroupName?.Count()?? 0} entity exercises");
            });

            Console.WriteLine("GetExerciseWithScores");
            await GetExerciseWithScores(client);
            Console.WriteLine("GetEntityExerciseWithScores");
            await GetEntityExerciseWithScores(client);

        } else
        {
            Console.WriteLine("No organism visible for authentificated user");
        }
    }

    private static HttpClient ConnectToApi(Uri apiUri)
    {
        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        HttpClient client = new HttpClient(handler);
        client.BaseAddress = new Uri("https://" + apiUri.Authority);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        return client;
    }

    private static HttpClient ConnectToApiIpAndPort(string ipAndPort)
    {
        Uri apiUri = new Uri("https://" + ipAndPort);
        return ConnectToApi(apiUri);
    }

    private static void SetAuthorisationHeaderIfNeeded(HttpClient client, bool force = false)
    {
        if (force)
        {
            client.DefaultRequestHeaders.Authorization = null;
        }
        if (client.DefaultRequestHeaders.Authorization == null)
        {
            var signInInfo = new SignInDto("password", "username"); // Use your own credentials for Skedge here
            string? tokenResponse = GetClientToken(client, signInInfo);
            var tokenObject = JsonConvert.DeserializeObject<dynamic>(tokenResponse);
            string? token = tokenObject?.token;
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                Console.WriteLine("Authenticated");
            }
        }
    }

    private static string? GetClientToken(HttpClient client, SignInDto signInInfo)
    {
        try
        {
            string token = string.Empty;
            StringContent content = new StringContent(JsonConvert.SerializeObject(signInInfo), Encoding.UTF8, "application/json");
            var uri = new Uri(client.BaseAddress + "api/Account/signin");
            Console.WriteLine("signIn uri: " + uri.ToString());
            HttpResponseMessage response;
            response = client.PostAsync(uri, content).Result;
            if (response.IsSuccessStatusCode)
            {
                token = response.Content.ReadAsStringAsync().Result;
            }
            return token.TrimEnd('"').TrimStart('"');
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to get client token: {ex.Message}");
        }
    }

    public class SignInDto 
    { 
        public string Password { get; set; }
        public string UserName { get; set; }

        public SignInDto(string password, string username)
        {
            Password = password;
            UserName = username;
        }
    }


    #region requests
    public static async Task<List<OrganismLightClientDto>> GetOrganisms(HttpClient client)
    {
        var response = await client.GetAsync("/api/ClientAccess/organisms?culture=en");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var organisms = JsonConvert.DeserializeObject<List<OrganismLightClientDto>>(content);
            return organisms;
        }
        else
        {
            throw new Exception($"Failed to get organisms: {response.StatusCode}");
        }
    }

    public static async Task<List<EntityLightClientDto>> GetEntitiesByOrganism(int organismId, HttpClient client)
    {
        var response = await client.GetAsync("/api/ClientAccess/organism/" + organismId.ToString() + "/entities?culture=en");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var entities = JsonConvert.DeserializeObject<List<EntityLightClientDto>>(content);
            return entities;
        }
        else
        {
            throw new Exception($"Failed to get entities: {response.StatusCode}");
        }
    }

    public static async Task<EntityClientDto> GetEntityDetail(int organismId, int entityId, HttpClient client)
    {
        var response = await client.GetAsync("/api/ClientAccess/organism/" + organismId.ToString() + "/entity/" + entityId.ToString());

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var entity = JsonConvert.DeserializeObject<EntityClientDto>(content);
            return entity;
        }
        else
        {
            throw new Exception($"Failed to get entity: {response.StatusCode}");
        }
    }

    public static async Task<List<ExerciseWithEntityExerciseClientDto>> GetExercisesByOrganism(int organismId, HttpClient client)
    {
        var response = await client.GetAsync("/api/ClientAccess/organism/" + organismId.ToString() + "/exercises");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exercises = JsonConvert.DeserializeObject<List<ExerciseWithEntityExerciseClientDto>>(content);
            return exercises;
        }
        else
        {
            throw new Exception($"Failed to get exercises: {response.StatusCode}");
        }
    }

    public static async Task<string> GetExerciseWithScores(HttpClient client, int organismId = 0, int exerciseId = 0)
    {
        var response = await client.GetAsync("/api/ClientAccess/organism/" + organismId.ToString() + "/exercise/" + exerciseId.ToString());

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("GetExerciseWithScores");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response.StatusCode.ToString());
            Console.WriteLine(content);
            return content;
        }
        else
        {
            throw new Exception($"Failed to get exercises: {response.StatusCode}");
        }
    }

    public static async Task<string> GetEntityExerciseWithScores(HttpClient client, int organismId = 0, int entityExerciseId = 0)
    {
        var response = await client.GetAsync("/api/ClientAccess/organism/" + organismId.ToString() + "/entity-exercise/" + entityExerciseId.ToString());

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("GetEntityExerciseWithScores");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response.StatusCode.ToString());
            Console.WriteLine(content);
            return content;
        }
        else
        {
            throw new Exception($"Failed to get exercises: {response.StatusCode}");
        }
    }

    #endregion
}
