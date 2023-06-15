using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class Editor
    {
        public void openProject(String path)
        {
            List<IArtifact> artefacts = new List<IArtifact>
            {
                new MainMarkerArtifact(new Artifact("Main")),
                new Artifact("Demo"),
                new ErrorMarkerArtefact(new Artifact("EmailClient")),
                new MainMarkerArtifact( new ErrorMarkerArtefact( new Artifact("EmailProvider"))),
            };

            foreach(var artefact in artefacts)
                Console.WriteLine(artefact.render());
        }
    }
}
