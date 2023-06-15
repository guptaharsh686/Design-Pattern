using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class ErrorMarkerArtefact : IArtifact
    {
        private IArtifact artifact;

        public ErrorMarkerArtefact(IArtifact artifact) : base(artifact.name)
        {
            this.artifact = artifact;
        }

        public override string render()
        {
            var data = artifact.render();
            return $"{data} [Error]";
        }
    }
}
