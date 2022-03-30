using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    /**
     *      Additional Class
     */
    [Serializable]
    class InvalidInputException : Exception
    {
        /// <summary>
        /// Represents errors of user input
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        public InvalidInputException(string message) : base(message){}        
    }
}
