using System;
using System.IO;
using MiNET.Worlds;
using MiNET;

namespace Restarter{

   public class Restarter : Plugin{
   
   public Timer _timer;
   
      private override onEnable(){
        Console.WriteLine("Enabled Restarted for MiNET");
        _timer = new Timer(RestartTick, null, 1, 1000);
      }
      
      private int time = 60;
      
      public void RestartTick(object state){
          time--;
          if(time == 0){
              
          }
      }         
      }
}
