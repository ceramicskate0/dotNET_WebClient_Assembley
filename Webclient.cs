using System;
using System.Net;

namespace dotNetWebClient
{
    public class Program
    {
        private static WebClient Wclient = new WebClient();
        
        public static void Main(string[] args)
        {  
          //pass args to file to download file else dont if hardcoded
          if (args.Length>0)
          {
              //Download data will load to memory
             //Wclient.DownloadData(args[0], args[1])
             Wclient.DownloadFile(args[0], args[1]);
             //Put your code to deal with file here
          }
          else
          {
              //Download data will load to memory
             //Wclient.DownloadData(//PUT YOUR CODE HERE, //PUT YOUR CODE HERE);
             Wclient.DownloadFile(//PUT YOUR CODE HERE, //PUT YOUR CODE HERE);
             //Put your code to deal with file here
          }
        }       
     }
 }
