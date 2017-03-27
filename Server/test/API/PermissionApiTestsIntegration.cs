/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using Newtonsoft.Json;
using SchoolBusAPI.Mappings;
using SchoolBusAPI.Models;
using SchoolBusAPI.ViewModels;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace SchoolBusAPI.Test
{
    public class PermissionApiIntegrationTest : ApiIntegrationTestBase
    { 
        [Fact]
        /// <summary>
        /// Integration test for Users Bulk
        /// </summary>
        public async void TestPermissionsBulk()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/permissions/bulk");
            request.Content = new StringContent("[]", Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        /// <summary>
        /// Integration test for Users
        /// </summary>
        public async void TestPermissions()
        {
            string initialName = "InitialName";
            string changedName = "ChangedName";
            // first test the POST.
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/permissions");

            // create a new object.
            PermissionViewModel newPermission = new PermissionViewModel();
            newPermission.Name = initialName;
            string jsonString = newPermission.ToJson();

            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // parse as JSON.
            jsonString = await response.Content.ReadAsStringAsync();

            Permission permission = JsonConvert.DeserializeObject<Permission>(jsonString);
            // get the id
            var id = permission.Id;
            // change the name
            permission.Name = changedName;

            PermissionViewModel permissionViewModel = permission.ToViewModel(); 

            // now do an update.
            request = new HttpRequestMessage(HttpMethod.Put, "/api/permissions/" + id);
            request.Content = new StringContent(permissionViewModel.ToJson(), Encoding.UTF8, "application/json");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // do a get.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/permissions/" + id);
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // parse as JSON.
            jsonString = await response.Content.ReadAsStringAsync();
            permission = JsonConvert.DeserializeObject<Permission>(jsonString);

            // verify the change went through.
            Assert.Equal(permission.Name, changedName);

            // do a delete.
            request = new HttpRequestMessage(HttpMethod.Post, "/api/permissions/" + id + "/delete");
            response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            // should get a 404 if we try a get now.
            request = new HttpRequestMessage(HttpMethod.Get, "/api/permissions/" + id);
            response = await _client.SendAsync(request);
            Assert.Equal(response.StatusCode, HttpStatusCode.NotFound);
        }

    }
}
