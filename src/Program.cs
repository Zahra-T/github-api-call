using System;
using System.Web;


namespace ApiCall
{
    class Program
    {
        public static void Main(string [] args){
            string command = args[0];
            GithubApiCall apiCall = new GithubApiCall();

            if(command == "repo"){
                string username = args[1];
                Console.WriteLine(apiCall.GetRepos(username));
            }
            else{
                Console.WriteLine("command " + args[0] + " not found");
            }
        }

 
    }
}
