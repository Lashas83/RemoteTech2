﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteTech {
    public class Path<T> {
        public bool Exists { get { return Nodes.Count > 0; } }
        public readonly List<T> Nodes;
        public readonly float Cost;

        public Path(List<T> nodes, float cost) {
            Nodes = nodes;
            Cost = cost;
        }
    }

    public class Path {
        public static Path<T> Instance<T>(List<T> nodes, float cost) {
            return new Path<T>(nodes, cost);
        }

        public static Path<T> Empty<T>() {
            return new Path<T>(new List<T>(), Single.PositiveInfinity);
        }
    }
}