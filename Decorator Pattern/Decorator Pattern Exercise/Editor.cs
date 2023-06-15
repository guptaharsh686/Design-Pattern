using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class Editor
    {
        public void openProject(String path)
        {
            List<Artefact> artefacts = new List<Artefact>
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            artefacts[0].setMain(true);
            artefacts[2].setHasError(true);

            foreach(var artefact in artefacts)
                Console.WriteLine(artefact.render());
        }
    }
}
