# Retrieving an Embedded Resource

I am trying to retrieve the **ResourceStyle.css** embedded resource by using the **Page.ClientScript.GetWebResourceUrl()** method. However, I receive a 404 resource not found error when I try to browse to the url that GetWebResourceUrl returns.

I have already set the build action for ResourceStyle.css to Embedded Resource and added the [assembly: WebResource()] attribute in the Default.aspx.cs file.

If you know how to resolve this issue, please fork the repository and make the necessary changes and then send me a pull request. Look at the Default.aspx.cs file for the pertinent code.

Thanks for your help
