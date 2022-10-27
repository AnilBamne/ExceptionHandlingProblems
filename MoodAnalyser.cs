using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHandlingPrograms
{
    public class MoodAnalyser
    {

        /// <summary>
        /// Global variable
        /// To store the input message
        /// </summary>
        private string message;

        ///<summary>
        ///Constructor
        ///To initialise the globle variable
        ///</summary>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string checkMood()
        {
            if(this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }



    }
}
