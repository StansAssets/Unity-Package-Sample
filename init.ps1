 param (
        [Parameter(Mandatory = $true)]
        [string[]]$ProjectName,
        [Parameter(Mandatory = $true)]
        [string[]]$Namespace
    )

#Set Namespaces#
Get-ChildItem ".\*.json" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'com.stansassets.package-sample', $ProjectName | Set-Content $_
}
Get-ChildItem ".\*.cs" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'com.stansassets.package-sample', $ProjectName | Set-Content $_
}
Get-ChildItem ".\*.md" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'com.stansassets.package-sample', $ProjectName | Set-Content $_
}

#Set Package  Scope#
Get-ChildItem ".\*.json" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'com.stansassets', $ProjectName.Substring(0,$ProjectName.LastIndexOf(".")) | Set-Content $_
}

#Set Project Names#
Get-ChildItem ".\*.cs" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'StansAssets.PackageSample', $Namespace | Set-Content $_
}
Get-ChildItem ".\*.asmdef" -Recurse | ForEach-Object -Process {
    (Get-Content $_) -Replace 'StansAssets.PackageSample', $Namespace | Set-Content $_
}

#Rename files#
ChildItem .\ -Recurse | Where-Object { $_.name -like 'com.stansassets.package-sample*'} | Rename-Item -NewName { $_.name -replace 'com.stansassets.package-sample', $ProjectName}
ChildItem .\ -Recurse | Where-Object { $_.name -like 'StansAssets.PackageSample*'} | Rename-Item -NewName { $_.name -replace 'StansAssets.PackageSample', $Namespace}

echo "package name: $ProjectName"
echo "package namespace: $Namespace"