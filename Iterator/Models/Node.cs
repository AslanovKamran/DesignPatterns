using System.Collections;

namespace Iterator.Models
{
	class Node<T> 
	{
		public T Data { get; }
		public Node<T>? Next { get; set; }
		public Node(T data) => Data = data;
	}

	class NodeList<T> : IEnumerable
	{
		public Node<T> Head { get; set; }

		public int Count { get; private set; } = 1;

		public NodeList(T head) => Head = new Node<T>(head);

		public void AddLast(T data)
		{
			Count++;
			Node<T>? current = Head;
			while (current.Next != null)
			{
				current = current.Next;
			}
			current.Next = new Node<T>(data);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			Node<T>? current = Head;
			while (current != null)
			{
				yield return (current.Data);
				current = current.Next;
			}
		}
	}

}
