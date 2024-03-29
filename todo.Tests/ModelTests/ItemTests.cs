using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {

    public void Dispose()
    {
        Item.ClearAll();
    }
      [TestMethod]
      public void ItemConstructor_CreatesInstanceOfItem_Item()
      {
          Item newItem = new Item("");
          Assert.AreEqual(typeof(Item), newItem.GetType());
      }


      [TestMethod]
      public void GetDescription_ReturnDescription_String()
      {
          //Arrange
          string description = "walk the dog";
          Item newItem = new Item("walk the dog");
          
          //Act
          string result = newItem.Description;
          
          //Assert
          Assert.AreEqual(description, result);
      }


      [TestMethod]
      public void SetDescription_SetDescription_String()
      {
          //Arrange
          string description = "walk the dog";
          Item newItem = new Item(description);

          //Act
          string updatedDescription = "do the dishes";
          newItem.Description = updatedDescription;
          string result = newItem.Description;

          //Assert
          Assert.AreEqual(updatedDescription, result);
      }

      [TestMethod]
      public void GetAll_ReturnsEmptyList_ItemList()
      {
          //Arrange
          List<Item> newList= new List<Item> {};
          //Act
          List<Item> result = Item.GetAll();
        //   foreach (Item thisItem in result)
        //   {
        //       Console.WriteLine("Output from empty list GetAll: " + thisItem.Description);
        //   }
          
          //Assert
          CollectionAssert.AreEqual(newList,result);

          
      }
      [TestMethod]
      public void GetAll_ReturnsItems_ItemList()
      {
          //Arrange
          string description01 = "Walk the dog";
          string description02 = "Wash the Dishes";
          Item newItem1 = new Item(description01);
          Item newItem2 = new Item(description02);
          List<Item> newList = new List<Item> {newItem1, newItem2};

          //Act
          List<Item> result = Item.GetAll();
          foreach (Item thisItem in result)
            {
                Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
            }
          foreach (Item thisItem in newList)
            {
                Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
            }

          //Assert
          CollectionAssert.AreEqual(newList, result);
      }
  }
}