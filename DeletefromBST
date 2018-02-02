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
    while(cur->left!=NULL)
    {
        cur=cur->left;
    }
    return cur;
}
node* del(node* temp,int val)
{
    if(temp==NULL)
    return temp;
    
    if(val<temp->info)
    temp->left=del(temp->left,val);
    else if(val>temp->info)
    temp->right=del(temp->right,val);
    else
    {
        if(temp->left==NULL)
        {
            node* temp1=temp->right;
            free(temp);
            return temp1;
        }
        else if(temp->right==NULL)
        {
            node* temp1=temp->left;
            free(temp);
            return temp1;
        }
        node* temp1=inordersucc(temp->right);
        temp->info=temp1->info;
        
        temp->right=del(temp->right,temp1->info);
    }
    return temp;
}
int main()
{
    int t;
    cin>>t;
    while(t--){
    int n;
    scanf("%d",&n);
    for(int i=0; i<n; i++)
    {
        temp=(node*)malloc(sizeof(node));
        scanf("%d",&temp->info);
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
int m;
cin>>m;

for(int i=0;i<m;i++)
{
    int val;
    cin>>val;
    temp=del(temp,val);
    //cout<<temp->info<<" ";
}

preorder(temp);
cout<<endl;
}
}
