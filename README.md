## Versioning in RestAPI

Types of API Versioning

  •	Query String Parameter Versioning.
  
      Ex : https://localhost:44347/api/VersioningDemo?api-version=1.0

  •	Media/Header API Versioning.
      
      Ex : https://localhost:44347/api/VersioningDemo add X-Version = 2.0 or accept = application/json;ver=2.0 in Header

  •	URI Versioning.
      
      Ex: https://localhost:44347/api/V3/VersioningDemo (v3 is the uri version)

  •	Deprecating Previous Versions
  
       API Versioning package allows us to flag APIs as deprecated. So this gives time to the client to prepare changes. Otherwise immediately deleting older APIs          could give a bad taste to clients.
       Ex [ApiVersion("1.0", Deprecated = true)] at controller level

Required Packages for API Versioning

    •	Microsoft.Aspnetcore.Mvc.Versioning
    •	Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
    
Add extension in Configureservices in startup.cs file

          services.AddApiVersioning(version =>
          {
              version.AssumeDefaultVersionWhenUnspecified = true;
              version.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
              version.ReportApiVersions = true;
              version.ApiVersionReader = ApiVersionReader.Combine(
                              new QueryStringApiVersionReader("api-version"),
                              new HeaderApiVersionReader("X-Version"),
                              new MediaTypeApiVersionReader("ver"));
          });
          services.AddVersionedApiExplorer(options =>
          {
              options.GroupNameFormat = "'v'VVV";
              options.SubstituteApiVersionInUrl = true;
          });
