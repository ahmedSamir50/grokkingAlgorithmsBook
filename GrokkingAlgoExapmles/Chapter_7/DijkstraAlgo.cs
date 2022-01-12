using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles
{
    public class DijkstraAlgo
    {
        public List<TreeNode> GraphPathDescription = new List<TreeNode>();

        public double GetGraphShortestPath()
        {

            return 0;
        }
    }

   

    public class TreeNode : ILinkNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="nodename">The nodename.</param>
        public TreeNode(string nodename)
        {
            this.NodeName = nodename;
            this.Neigbores = null;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="name">The value.</param>
        /// <param name="neigbors">The  node neigbors.</param>
        public TreeNode(string name, Dictionary<TreeNode, double> neigbors)
        {
            this.NodeName = name;
            this.Neigbores = neigbors;
        }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// Gets or sets the node neighbors with it's path cost.
        /// </summary>
        public Dictionary<TreeNode , double> Neigbores { get; set; }

    }

    

    public interface ILinkNode
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string NodeName { get; set; }
    }
}
