﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}