# RayNotationGenerator
<img src="https://i.imgur.com/p5PTYlV.png"></img>

Encodes a string of Unicode characters into Ray Notation image.

## 'Ray notation'?
It's something I came up with when learning about binary and playing around with different ways of representing it visually.  
Each byte is represented by a single character with eight possible 'ray' positions extending from the centre. Each ray is drawn only if that bit is set to 1, otherwise that ray is not drawn and leaves a gap.  
For example, the image above reads 'Ray Notation' when encoded with UTF-8.
