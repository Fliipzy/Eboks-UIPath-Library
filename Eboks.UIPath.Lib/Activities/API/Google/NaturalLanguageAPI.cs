using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Activities.API.Google
{
    [DisplayName("Google Natural Language AutoML API")]
    [Description("Sends a POST request to the Google NL autoML API and returns a prediction in json format.")]
    public sealed class NaturalLanguageAPI : CodeActivity
    {
        [Category("Input")]
        [DisplayName("Project ID")]
        [Description("The project identification e.g 281959524626.")]
        public InArgument<string> ProjectID { get; set; }

        [Category("Input")]
        [DisplayName("Model ID")]
        [Description("The model identification e.g TCN6322539305386377216.")]
        public InArgument<string> ModelID { get; set; }

        [Category("Input")]
        [DisplayName("Location ID")]
        [Description("The location identification e.g us - central1.")]
        public InArgument<string> LocationID { get; set; }

        [Category("Input")]
        [DisplayName("Bearer token")]
        [Description("The bearer token credentials. Found by using the gcloud terminal program.")]
        public InArgument<string> BearerToken { get; set; }

        [Category("Input")]
        [DisplayName("Text content")]
        [Description("The text content that will be predicted.")]
        public InArgument<string> Content { get; set; }

        private HttpWebRequest request;

        protected override void Execute(CodeActivityContext context)
        {
            var projectID = ProjectID.Get(context);
            var modelID = ModelID.Get(context);
            var locationID = LocationID.Get(context);
            var bearerToken = BearerToken.Get(context);
            var content = Content.Get(context);

            var jsonData = String.Format("{ \"payload\": { \"textSnippet\": { \"content\": \"{0}\", \"mime_type\": \"text/plain\" } } }", content);
            var jsonDataBytes = Encoding.ASCII.GetBytes(jsonData);

            request = HttpWebRequest.CreateHttp(String.Format("https://automl.googleapis.com/v1/projects/{0}/locations/{1}/models/{2}:predict",
                                                    projectID, locationID, modelID));
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {bearerToken}");

            using (var req_stream = request.GetRequestStream())
            {
                req_stream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
                req_stream.Close();
            }

            var response = request.GetResponse();
            
        }
    }
}
