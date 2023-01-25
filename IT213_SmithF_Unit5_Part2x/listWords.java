
public class listWords {

	public static void main(String[] args) {
		
		    String sentence =  "The quick brown fox jumps over the lazy dog."; 														//set sentence to "I stole this sentence"
	        int wordCount = 1; 																										//my wordcount variable to count, ya know, words....
	        String[] word = sentence.split("\\s+");																					//converting my string to an array to use the split method
	        
	        for(int i = 0; i < sentence.length(); i++) 																				
	        	if(sentence.charAt(i) == ' ' && i < sentence.length() - 1 && sentence.charAt(i + 1) != ' ') 						//parameters for what is considered a "word"(again, 
	        																													 //loops not a strong suit so I stripped an old assignment for this										
	        		
	        		  wordCount ++;																									//adding 1 to word count
	        
	        for(String w : word)																	
	    		System.out.println(w);																									//having my array print each word in the sentence 
	        		
	        
	        	
	        
	        System.out.println("There are " + wordCount + " words in the sentence");														//total count of words at the end
	        
	        

		}

	}


