#include<bits/stdc++.h>
using namespace std;

struct Node
{
    int key;
    Node *left, *right;
};
 
Node *newNode(int key)
{
    Node *temp = new Node;
    temp->key  = key;
    temp->left  = temp->right = NULL;
    return (temp);
}

void createNode(int parent[], int i, Node *created[], Node **root)
{
    if (created[i] != NULL)
        return;
 
    created[i] = newNode(i);

    if (parent[i] == -1)
    {
        *root = created[i];
        return;
    }
 
    if (created[parent[i]] == NULL)
        createNode(parent, parent[i], created, root);
        
    Node *p = created[parent[i]];

    if (p->left == NULL)
        p->left = created[i];
    else 
        p->right = created[i];
}
 
Node *createTree(int parent[], int n)
{
    Node *created[n];
    for (int i=0; i<n; i++)
        created[i] = NULL;
 
    Node *root = NULL;
    for (int i=0; i<n; i++)
        createNode(parent, i, created, &root);
 
    return root;
}
void getVerticalOrder(Node* root, int hd, map<int, vector<int>> &m)
{
    if (root == NULL)
        return;
 
    // Store current node in map 'm'
    m[hd].push_back(root->key);
 
    // Store nodes in left subtree
    getVerticalOrder(root->left, hd-1, m);
 
    // Store nodes in right subtree
    getVerticalOrder(root->right, hd+1, m);
}

void vertical(Node* root)
{
    map <int,vector<int> > m;
    getVerticalOrder(root,0,m);
 
    map<int,vector<int> > :: iterator it;
    for (it=m.begin(); it!=m.end(); it++)
    {
        for (int i=0; i<it->second.size(); ++i)
            cout << it->second[i] << " ";
        cout << endl;
    }
}

int main() {
    int t;
    cin>>t;
    while(t--){
        int n;
        cin>>n;
        int a[n];
        
        for(int i=0;i<n;i++)
        cin>>a[i];
        Node *temp=createTree(a,n);
        
       vertical(temp);
        
        cout<<endl;
    }
	return 0;
}
