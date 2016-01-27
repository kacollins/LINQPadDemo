<Query Kind="VBExpression">
  <Connection>
    <ID>819d5504-dc9b-46f3-a2f9-ba3b3478d172</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>AdventureWorks2012</Database>
  </Connection>
</Query>

Products.Where(Function(p) p.ListPrice > 10) _
		.OrderBy(Function(p) p.ListPrice)
		
