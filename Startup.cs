using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CoreApp {
    public class Startup{

        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                return context.Response.WriteAsync("Agilicus Rocks\n");
            });
            
        }
    }
}
