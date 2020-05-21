using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesCategoryInstance_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test";
      Category newCategory = new Category(name);
      string result = newCategory.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetID_ReturnsCategoryID_Int()
    {
      string name = "test";
      Category newCategory = new Category(name);
      int result = newCategory.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      string name1 = "Work";
      string name2 = "School";
      Category newCategory1 = new Category(name1);
      Category newCategory2 = new Category(name2);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };
      List<Category> result = Category.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsDesiredCategory_Category()
    {
      string name1 = "Work";
      string name2 = "School";
      Category newCategory1 = new Category(name1);
      Category newCategory2 = new Category(name2);
      Category result = Category.Find(2);
      Assert.AreEqual(newCategory2, result);
    }
    }
}