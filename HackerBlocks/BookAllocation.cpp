#include<bits/stdc++.h>
using namespace std;

bool isvalid(int a[],int n,int m,int mid)
{
    int students=1;
    int cur=0;
    for(int i=0;i<n;i++){
        if(a[i]>mid)return false;
    if(cur+a[i]>mid)
    {
       
        students++;
       cur=a[i];
    }
    else{
        cur+=a[i];
    }
    
    if(students>m)
    return false;
    }
    return true;
}
int main() {
    int t;
    cin>>t;
    while(t--)
    {
        int n,m,s=0;
        cin>>n>>m;
        int a[n];
        for(int i=0;i<n;i++){
        cin>>a[i];
        s+=a[i];
            
        }
        
        int beg=0,end=s,mid=(beg+end)/2,ans=end;
        while(beg<=end)
        {
            if(isvalid(a,n,m,mid))
            {
                ans=min(ans,mid);
                end=mid-1;
            }
            else
            {
                beg=mid+1;
            }
            mid=(beg+end)/2;
        }
        cout<<ans<<endl;
    }
	return 0;
}
