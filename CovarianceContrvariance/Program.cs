using System;
using System.Collections;
using System.Collections.Generic;

namespace CovarianceContrvariance
{
    class Program
    {
        static void Main(string[] args)
        {
            ICovariantTree<Order> orderTree = new CovariantTree<Order>();
            ICovariantTree<IOrder> iOrderTree = orderTree;

            ContrvariantTree<Order> orderTree2 = new ContrvariantTree<Order>();
            IContrvariantTree<CombinedOrder> combinedOrderTree = orderTree2;


            /* Not compiled because of absence of covariance, contrvariance modificators

            ICovariantTree<Order> orderTree = new CovariantTree<Order>();
            ICovariantTree<CombinedOrder> iOrderTree = orderTree;

            ContrvariantTree<Order> orderTree2 = new ContrvariantTree<Order>();
            IContrvariantTree<IOrder> combinedOrderTree = orderTree2;

            ITree<Order> orderTree3 = new Tree<Order>();
            ITree<IOrder> iorderTree3 = orderTree3;
            
            ITree<Order> orderTree4 = new Tree<Order>();
            ITree<CombinedOrder> combinedOrderTree3 = orderTree4;
            */

        }

        public interface ITree<T>
        {
        }

        public class Tree<T> : ITree<T>
        {
        }

        public interface ICovariantTree<out T>
        {
        }
       
        public class CovariantTree<T> : ICovariantTree<T>
        {
        }

        public interface IContrvariantTree<in T>
        {
        }

        public class ContrvariantTree<T> : IContrvariantTree<T>
        {
        }

        public interface IOrder
        {
        }

        public class Order : IOrder
        {
        }

        public class CombinedOrder : Order
        {
        }
    }
}
