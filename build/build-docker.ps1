$Branch=$env:APPVEYOR_REPO_BRANCHAPPVEYOR_PULL_REQUEST_HEAD_REPO_BRANCH
Write-Host $Branch
$IsMaster=$Branch -eq "master"
if ($IsMaster) {
    exit 0
}

Write-Host Starting build docker
$Version=$env:APPVEYOR_BUILD_VERSION

docker build -t dotnetru/server:latest -t dotnetru/server:$Version .