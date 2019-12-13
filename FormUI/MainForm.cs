using Microsoft.Glee.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        Graph graph;
        int[,] graphArr;
        List<Edge> edgeList;
        List<Edge> minEdges;
        static int[] visited;
        static int[] path;
        static int vertex;
        static int min;

        public MainForm()
        {
            InitializeComponent();
        }

        public struct Edge
        {
            public int u, v, d;
        }

        public void addEdge(List<Edge> edgeList, int u, int v, int d)
        {
            Edge edge = new Edge();
            edge.u = u; edge.v = v; edge.d = d;
            edgeList.Add(edge);
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text documents (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graphRb.Checked = true;
                graph = new Graph("graph");
                fileTb.Clear();
                resTb.Clear();
                string fileArr;
                fileLbl.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                int size = fileArr.Split('\n').Length;
                graphArr = new int[size, size];
                vertex = size;
                int i = 0, j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        graphArr[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                foreach (var row in fileArr.Split('\n'))
                {
                    string strrow = row.Trim();
                    fileTb.AppendText(strrow + Environment.NewLine);
                }

                int n = graphArr.GetLength(0);

                edgeList = new List<Edge>();
                for (i = 0; i < n; i++)
                {
                    if (i == 0)
                        j = i + 1;
                    else
                        j = 0;
                    for (; j < n; j++)
                    {
                        if (graphArr[i, j] != 0)
                        {
                            addEdge(edgeList, i, j, graphArr[i, j]);
                        }
                    }
                }
                resTb.AppendText("Node and distance: (u, v) : d" + Environment.NewLine);
                foreach (Edge edge in edgeList)
                {
                    graph.AddEdge(edge.u.ToString(), graphArr[edge.u, edge.v].ToString(), edge.v.ToString());
                    string str = "(" + edge.u + ", " + edge.v + ") : " + edge.d;
                    resTb.AppendText(str + Environment.NewLine);
                }

                foreach (var edge in graph.Edges)
                {
                    edge.Attr.LineWidth = 2;
                }

                graph.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer.OutsideAreaBrush = Brushes.White;
                graphViewer.Graph = graph;

                resTb.AppendText(Environment.NewLine);
            }
        }

        static void TSP(int[,] graph, int node, int passed, int dist)
        {
            visited[passed] = node;
            if (passed == (vertex - 1))
            {
                int length = dist + graph[0, node];
                if (length < min)
                {
                    min = length;
                    for (int i = 0; i < vertex; i++) path[i] = visited[i];
                }
            }
            else
            {
                for (int next = 0; next < vertex; next++)
                {
                    if (dist + graph[node, next] < min)
                    {
                        bool next_unvisited = true;
                        for (int i = 0; i < passed + 1 && next_unvisited; i++)
                            if (visited[i] == next) next_unvisited = false;
                        if (next_unvisited)
                            TSP(graph, next, passed + 1, dist + graph[node, next]);
                    }
                }
            }
        }

        private void findPathBtn_Click(object sender, EventArgs e)
        {
            minEdges = new List<Edge>();
            min = int.MaxValue;
            visited = new int[vertex];
            path = new int[vertex];
            TSP(graphArr, 0, 0, 0);
            resTb.AppendText("Optimal distance: " + min + Environment.NewLine);
            resTb.AppendText("Route: ");
            for (int i = 0; i < vertex; i++)
                resTb.AppendText(path[i] + " ");
            resTb.AppendText("0");
            for (int i = 0; i < path.Count() - 1; i++)
            {
                addEdge(minEdges, path[i], path[i + 1], graphArr[path[i], path[i + 1]]);
            }
            addEdge(minEdges, path[path.Count() - 1], 0, graphArr[path[path.Count() - 1], 0]);
            resTb.AppendText(Environment.NewLine);
            graphrbMp.Enabled = true;
        }

        private void graphRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graphRb.Checked)
            {
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }

                graphViewer.Refresh();
            }
        }

        private void graph_minRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_minRb.Checked)
            {
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }


                if (minEdges.Count > 0)
                {
                    foreach (var edge in graph.Edges)
                    {
                        foreach (var min_e in minEdges)
                        {
                            if (edge.Source == min_e.u.ToString() && edge.Target == min_e.v.ToString())
                            {
                                edge.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                                edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Green;
                                edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                                edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                            }
                        }
                    }
                }

            }
            graphViewer.Refresh();
        }
    }
}
