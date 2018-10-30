/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 29.10.2018
 * Time: 17:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trees
{
	class Program
	{
		public static void Main(string[] args)
		{
			BinaryTree<int> btree = new BinaryTree<int>(33, null);
			int [] vals = new int[]{5, 35, 1, 20, 4, 17, 31, 99, 18, 19};
			Array.ForEach(vals, new Action<int>((i) => btree.add(i)));
			btree.print();
			btree.remove(33);
			btree.print();
			Console.ReadKey();
		}
	}
}