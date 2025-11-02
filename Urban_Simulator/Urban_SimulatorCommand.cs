using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;

namespace Urban_Simulator
{
    public class Urban_SimulatorCommand : Command
    {
        public Urban_SimulatorCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static Urban_SimulatorCommand Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "Urban_Simulator";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            RhinoApp.WriteLine("The Urban Simulator Started");

            //getPrecint()                  //Asking the user to select a surface representing the Precinct
            //generateRoadNetwork()         //Using the Precinct, generate the road network
            //generateBlocks()              //Using the road network, generate blocks
            //subdivideBlocks()             //subdivide the blocks into plots
            //instiniateBuildings()         //Place building on each plot

            RhinoApp.WriteLine("The Urban Simulator Completed");

            return Result.Success;
        }
    }
}
