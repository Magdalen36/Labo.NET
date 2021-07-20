using Labo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.DataSet
{
    public class DataSetCalendrierJour : IEntityTypeConfiguration<CalendrierJour>
    {
        public void Configure(EntityTypeBuilder<CalendrierJour> builder)
        {

            DateTime today = DateTime.Now;
            int centreId = 1;
            
            for (int i = 1; i < 100; i++)
            {
                today = today.AddDays(1);
                if (i >= 100) centreId = 2;
                if (i >= 200) centreId = 3;
                builder.HasData(new CalendrierJour { 
                    Id = i, 
                    CentreId = 1, 
                    Day= today }
           );
            }

            DateTime today2 = DateTime.Now; //pas le mercredi

            for (int i = 100; i < 200; i++)
            {
                today2 = today2.AddDays(1);

                if((int)today2.DayOfWeek == 3) { }
                else
                {
                    builder.HasData(new CalendrierJour
                    {
                        Id = i,
                        CentreId = 2,
                        Day = today2
                    });
                }               
            }

            DateTime today3 = DateTime.Now; //pas les samedi et dimanche

            for (int i = 200; i < 300; i++)
            {
                today3 = today3.AddDays(1);

                if ((int)today3.DayOfWeek == 6 || (int)today3.DayOfWeek == 7) { }
                else
                {
                    builder.HasData(new CalendrierJour
                    {
                        Id = i,
                        CentreId = 3,
                        Day = today3
                    });
                }             
            }
        }
    }
}
