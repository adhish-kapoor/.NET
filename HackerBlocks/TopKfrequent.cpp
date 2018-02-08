#include<bits/stdc++.h>
using namespace std;
int main() {
    int t;
    cin>>t;
    while(t--){
        int n,k;
        cin>>n>>k;
        int a[n];
        for(int i=0;i<n;i++)
        cin>>a[i];
        vector<int>v(k+1);
        unordered_map<int,int>mp;//to count occurence of elements
        
        for(int i=0;i<n;i++)
        {
            mp[a[i]]++;
            
            v[k]=a[i]; //puts element in vector
            
            auto it=find(v.begin(),v.end()-1,a[i]);//finds same element in vector
            
            for(int i=distance(v.begin(),it)-1;i>=0;i--){
                if(mp[v[i]]<mp[v[i+1]])
                swap(v[i],v[i+1]);
                
                else if(mp[v[i]]==mp[v[i+1]] and v[i]>v[i+1])
                swap(v[i],v[i+1]);
                else
                break;
            }
            for(int i=0;i<k and v[i]!=0;i++)
        cout<<v[i]<<" ";
        }
        
        cout<<endl;
    }
	return 0;
}
