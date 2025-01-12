using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PageNavigator : MonoBehaviour
{
    public GameObject[] pages; // Array to hold your pages
    private int currentPageIndex = 0; // Start from the first page

    // Method to go to the next page
    public void GoToNextPage()
    {
        if (currentPageIndex < pages.Length - 1)
        {
            pages[currentPageIndex].SetActive(false); // Hide the current page
            currentPageIndex++;
            pages[currentPageIndex].SetActive(true); // Show the next page
        }
    }

    // Method to go to the previous page
    public void GoToPreviousPage()
    {
        if (currentPageIndex > 0)
        {
            pages[currentPageIndex].SetActive(false); // Hide the current page
            currentPageIndex--;
            pages[currentPageIndex].SetActive(true); // Show the previous page
        }
    }
}
