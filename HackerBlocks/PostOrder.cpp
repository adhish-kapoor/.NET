#include<bits/stdc++.h>
using namespace std;

int search(int a[],int element,int n)
{
    for(int i=0;i<n;i++)
    {
        if(a[i]==element)
        return i;
    }
    return -1;
}

void postorder(int in[],int pre[],int n){
    
    int root=search(in,pre[0],n);
    
    if(root!=0)
    postorder(in,pre+1,root);
    if(root!=n-1)
    postorder(in+root+1,pre+root+1,n-root-1);
    
    cout<<pre[0]<<" ";
}
int main()
{
    int t;
    cin>>t;
    while(t--)
    {
        int n;
        cin>>n;
        int in[n];
        int pre[n];
        for(int i=0;i<n;i++)
        cin>>in[i];
        for(int i=0;i<n;i++)
        cin>>pre[i];
        
        postorder(in,pre,n);
        
    }
}
