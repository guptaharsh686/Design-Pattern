﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class Artifact : IArtifact
    {
      
        //private bool hasError;
        //private bool isMain;

        public Artifact(String name) : base(name)
        {
        }

        public override String render()
        {
            // The current implementation is not easily extensible. If tomorrow we need
            // to support other special markers, we have to come back and modify this class.
            //
            // For example, if the project is under source control, we need to highlight
            // the artefacts that are changed but not committed to the repository with a
            // special marker.
            //
            // Similarly, if an artefact is excluded from the project, we may want to
            // make the icon look disabled or semi-transparent.
            //
            // Every time we need to support a new marker, we have to come back and modify
            // this class. Over time, the code in this class gets more and more convoluted
            // with several if statements and additional fields.

            //string errorIcon = hasError ? "[Error]" : "";
            //string mainIcon = isMain ? "[Main]" : "";

            return $"{name}";
        }

        //public void setHasError(bool hasError)
        //{
        //    this.hasError = hasError;
        //}

        //public void setMain(bool main)
        //{
        //    isMain = main;
        //}
    }
}
