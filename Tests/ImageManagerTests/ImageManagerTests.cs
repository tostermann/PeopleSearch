using ImgManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;

namespace ImageManagerTests
{
    [TestClass]
    public class ImageManagerTest
    {
        [TestMethod]
        public void CovertJpgToBase64String()
        {
            // Arrange
            string filePath = Directory.GetCurrentDirectory();
            int binFolderIndx = filePath.IndexOf("bin");
            filePath = filePath.Substring(0, binFolderIndx) + "InputFiles\\male.jpg";

            string expectedBase64String = "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";
            
            // Act

            string result = ImageManager.ImageToBase64(filePath);

            // Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBase64String, result);
        }
    }
}