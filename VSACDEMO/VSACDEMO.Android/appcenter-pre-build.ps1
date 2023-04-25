      $SLN_PATH = Get-ChildItem -Path '/Users/runner/work/1/s/VSACDEMO' -Include *.sln -recurse
      $AllProjects = Get-ChildItem -Path '/Users/runner/work/1/s/VSACDEMO' -Include *.csproj -Exclude "*Android*.csproj", "VSACDEMO.csproj" -Recurse

      write-host $SLN_PATH
      write-host $AllProjects
      
      foreach ($project in $AllProjects)
      {
          write-host "Removing $project from $SLN_PATH"
          dotnet sln $SLN_PATH remove $project
      }   