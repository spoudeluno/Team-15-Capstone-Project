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

ps 59029;
while [ $? -eq 0 ];
do
  sleep 1;
  ps 59029 > /dev/null;
done;

for child in $(list_child_processes 59030);
do
  echo killing $child;
  kill -s KILL $child;
done;
rm /Users/dreamxia/git/Team-15-Capstone-Project/btTemplate/btTemplate.Server/bin/Debug/net8.0/7b39dda6952f4909ae29b193fa772341.sh;
