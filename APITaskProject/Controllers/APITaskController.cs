using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaskProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APITaskController : ControllerBase
    {
       
        List<int> circle = new List<int>();
        int counter = 0;
        
        [HttpGet]
        public int Get(int sayi)
        {
            if (sayi % 2 == 1)
            {
                counter = 0;
            }
            else
            {
                counter = 1;
            }


            circle.Clear();
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 1)
                {
                    circle.Add(i);
                }

            }


            for (int i = 0; i <= sayi - 2; i++)
            {
                if (circle.Count > 1)
                {
                    if (counter == circle.Count && counter > 1) // son eleman silinmedigi zaman
                    {
                        counter = 0;
                        circle.RemoveAt(counter);
                        counter++;
                    }
                    else if (circle[counter] == circle[circle.Count - 1]) // son eleman silindigi zaman
                    {
                        circle.RemoveAt(counter);
                        counter = 1;
                    }


                    if (circle.Count > 1)
                    {
                        circle.RemoveAt(counter);
                        counter++;
                    }

                }

            }

            return circle[0];

        }

       
    }
}
