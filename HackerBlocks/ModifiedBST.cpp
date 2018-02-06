//deleting nodes not in given range
#include<bits/stdc++.h>
using namespace std;

struct node
{
int info;
node *left;
node *right;
}*temp,*root,*temp1;

void preorder(node* temp)
{
    if(temp==NULL)
    return;
    cout<<temp->info<<" ";
    preorder(temp->left);
    preorder(temp->right);
}
node* inordersucc(node* temp)
{
    node* cur=temp;
    while(cur->right!=NULL)
    {
        cur=cur->right;
    }
    return cur;
}
node* del(node* temp,int l,int r)
{
    if(temp==NULL)
    return temp;
    
    temp->left=del(temp->left,l,r);

    temp->right=del(temp->right,l,r);
   if(temp->info<l)
   {
       return temp->right;
   }
    if(temp->info>r)
   {
       return temp->left;
   }
    return temp;
}
int main()
{
    int t;
    cin>>t;
    while(t--){
    int n;
   cin>>n;
   int a[n];
   for(int i=0;i<n;i++)
   cin>>a[i];
    for(int i=0; i<n; i++)
    {
        temp=(node*)malloc(sizeof(node));
        temp->info=a[i];
        temp->right=NULL;
        temp->left=NULL;
        if(i==0)
        {
            root=temp;
        }
        else
        {
            temp1=root;
            while(1)
            {
                if((temp->info)>=(temp1->info))
                {
                    if(temp1->right==NULL)            //check before moving right
                        break;
                    temp1=temp1->right;
                }
                else
                {
                    if(temp1->left==NULL)            //check before moving left
                        break;
                    temp1=temp1->left;
                }

            }
            if(temp->info>=temp1->info)
                temp1->right=temp;
            else
                temp1->left=temp;
        }
    }
    temp=root;
    cout<<"Preorder : ";
    preorder(temp);
    cout<<endl;
int l,r;
cin>>l>>r;

    temp=del(temp,l,r);
   

 cout<<"Preorder : ";
preorder(temp);
cout<<endl;
}
}
