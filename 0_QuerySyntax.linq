<Query Kind="Expression">
  <Connection>
    <ID>819d5504-dc9b-46f3-a2f9-ba3b3478d172</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>AdventureWorks2012</Database>
  </Connection>
</Query>

from p in Products
where p.ListPrice > 10
orderby p.ListPrice
select p

