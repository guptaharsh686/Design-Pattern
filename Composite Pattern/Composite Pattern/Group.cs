using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Group
    {
        private List<Object> shapes = new List<Object>();
        //Representing shapes as Object type to get objects of group class as well as shape class.
        
        
        public void addShape(object shape)
        {
            shapes.Add(shape);
        }

        public void render()
        {
            foreach (var shape in shapes)
            {
                if(shape is Shape)
                {
                    ((Shape)shape).render();
                }
                //type checking and then calling render method according to type.
                else if(shape is Group)
                {
                    ((Group)shape).render();
                }
            }
            //problem with this approach is that
            //we are explicitely converting the types and for other functionality we have to do similar thing and repeat the code for
            //casting and checking.
        }

    }
}
