using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class MainMarkerArtifact : IArtifact
    {
        private IArtifact artifact;

        public MainMarkerArtifact(IArtifact artifact) : base(artifact.name)
        {
            this.artifact = artifact;
        }

        public override string render()
        {
            var data = artifact.render();
            return $"{data} [Main]";
        }
    }
}
