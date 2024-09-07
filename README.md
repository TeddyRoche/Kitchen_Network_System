This is a C# point of sales system based on a restaurant ordering/fulfilling. 
There are three seperate systems: PointOfSale_Kitchen, Network_Server, Network_Client
Each of these needs to be running at the same time for them to communicate with eachother. 
How to use:
1. You have to connect to both Network_Client and PointOfSale_Kitchen to Network_Server
2. Use your systems IP address to connect them.
   a. Windows: go to command line and type ipconfig. Use the IPv4 Address
   b. Mac: Apple -> About this Mac ->System Report -> Network.
   c. Windows: go to command line and type ifconfig. Use the IPv4 Address
3. Green Light should appear if connection worked.
4. Select table and click seat customer
5. Take that customers order
6. Fulfill customers order from kitchen
7. Deliver order
8. Pay for order
9. See end of day Report
10. Repeat

You dont have to do end of day report after every customer and you can sit multiple customers at once.
