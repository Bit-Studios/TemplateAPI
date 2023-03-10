using KerbalWebProgram;
using KerbalWebProgram.KerbalWebProgram;
using KSP.Game;

namespace TemplateAPI
{
    public static class ApiEndpoint
    {
        public static void init()
        {
            KerbalWebProgramMod.webAPI.Add("doStage", new getExampleEndpoint());
        }
    }

    //Example endpoint
    public class getExampleEndpoint : KWPapi
    {
        public override List<KWPParameterType> parameters { get; set; }

        public override string Type { get; set; }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override string Author { get; set; }

        public override List<string> Tags { get; set; }
        public getExampleEndpoint()
        {
            parameters = new List<KWPParameterType> {};
            Type = "response";
            Name = "Get Example Endpoint";
            Description = "Example api endpoint";
            Author = "Author name here";
            Tags = new List<string> { "Example" };
        }

        public override ApiResponseData Run(ApiRequestData request)
        {
            ApiResponseData response = new ApiResponseData();
            response.ID = request.ID;
            response.Type = "response";
            response.Data = new Dictionary<string, object>();
            response.Data.Add("SomeData", GameManager.Instance.Game.SessionGuidString);
            return response;
        }
    }
}