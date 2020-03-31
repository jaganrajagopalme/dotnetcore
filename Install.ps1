# Create folder to publish binaries from drop folder
mkdir c:\website-published

# Switch to drop folder
Set-Location C:\website-dropfolder   

# Restore the nuget references
& "C:\Program Files\dotnet\dotnet.exe" restore  

# Publish application with all of its dependencies and runtime for IIS to use
& "C:\Program Files\dotnet\dotnet.exe" publish --configuration release -o c:\website-published --runtime active  

# Create an IIS website and point it to the published folder
C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -Command {Import-Module WebAdministration; New-WebSite -Name CoreWebsite -Port 80 -HostHeader CoreWebsite -PhysicalPath "$env:systemdrive\website-published"}


# Create AppPool for website and set CLR version to core-dotnet
C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -Command {Import-Module WebAdministration; New-WebAppPool CoreWebsiteAppPool}
