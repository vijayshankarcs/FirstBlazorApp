using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieApp.Client
{
    public class SingletonServices
    {
        public int Value { get; set; }
    }
    public class TransientServices
    {
        public int Value { get; set; }
    }
}
