function list_child_processes () {
    local ppid=$1;
    local current_children=$(pgrep -P $ppid);
    local local_child;
    if [ $? -eq 0 ];
    then
        for current_child in $current_children
        do
          local_child=$current_child;
          list_child_processes $local_child;
          echo $local_child;
        done;
    else
      return 0;
    fi;
}

ps 60188;
while [ $? -eq 0 ];
do
  sleep 1;
  ps 60188 > /dev/null;
done;

for child in $(list_child_processes 60197);
do
  echo killing $child;
  kill -s KILL $child;
done;
rm /Users/dreamxia/git/Team-15-Capstone-Project/btTemplate/btTemplate.Server/bin/Debug/net8.0/1b087d7ab1f74c5bb2115f5ac2f53e8c.sh;
