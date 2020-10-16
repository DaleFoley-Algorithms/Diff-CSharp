using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string fileA = File.ReadAllText("../../JavaInstall.cpp");
        string fileB = File.ReadAllText("../../JavaInstallList.cpp");

        Diff diff = new Diff();
        Diff.Item[] diffItems = diff.DiffText(fileA, fileB);

        int diffItemLength = diffItems.Length;
    }
}
