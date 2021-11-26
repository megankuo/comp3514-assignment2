using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SpeakerContext>();
                context.Database.EnsureCreated();

                // Look for any Speakers
                if (context.Speakers != null && context.Speakers.Any())
                    return;   // DB has already been seeded

                var speakers = DummyData.GetSpeakers().ToArray();
                context.Speakers.AddRange(speakers);
                context.SaveChanges();

            }
        }

        public static List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>() {
        new Speaker {FirstName="Jim", LastName="Potter", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Jane", LastName="Douglas", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Ann", LastName="Lee", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="James", LastName="Jones", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Susan", LastName="Taylot", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Peter", LastName="White", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Philip", LastName="White", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"},
        new Speaker {FirstName="Donna", LastName="Rey", Email="jim@bar.ca", MobileNumber="604-123-4567", Specialization="Cloud Architect", City="Chilliwack", Province="BC", Employer="BC Hydro"}
    };
            return speakers;
        }




    }

}