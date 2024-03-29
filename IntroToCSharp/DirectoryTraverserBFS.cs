﻿using System;
using System.Collections.Generic;
using System.IO;

namespace IntroToCSharp
{
    /// <summary>
    /// Sample class, which traverses given directory
    /// based on the Breath-First-Search (BFS) algorithm
    /// </summary>
    class DirectoryTraverserBFS
    {
        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory /// which should be traversed</param>
        public static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue=new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);
                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }
    }
}
