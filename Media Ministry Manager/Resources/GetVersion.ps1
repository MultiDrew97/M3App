param(
    [string]$FilePath
)

(Get-Command $FilePath).FileVersionInfo.FileVersion