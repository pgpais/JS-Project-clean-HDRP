﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Color tabIdle;
    public Color tabHover;
    public Color tabActive;
    public TabButton selectedTab;

    public List<GameObject> objectsToSwap;

    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        
        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.background.color = tabHover;
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }
        
        selectedTab = button;
        
        selectedTab.Select();
        
        ResetTabs();
        button.background.color = tabActive;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            objectsToSwap[i].SetActive(i == index);
        }
    }

    private void ResetTabs()
    {
        foreach (var button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab) { continue; }
            button.background.color = tabIdle;
        }
    }
}
