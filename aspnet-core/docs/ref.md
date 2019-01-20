
[ABP从入门到精通（2）：aspnet-zero-core 使用MySql数据库](https://www.cnblogs.com/stulzq/p/7242581.html)

[解决mysql插入数据时出现Incorrect string value: '\xF0\x9F...' for column 'name' at row 1的异常](https://blog.csdn.net/azhegps/article/details/71480633)

将已经建好的表也转换成utf8mb4

命令：alter table TABLE_NAME convert to character set utf8mb4 collate utf8mb4_bin; （将TABLE_NAME替换成你的表名）



# Issuse

1. 数据表没有主键，无法进行逆向工程以生成实体类

Scaffold-DbContext "server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Scaffold-DbContext "server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;" Pomelo.EntityFrameworkCore.MySql -OutputDir Models



Unable to identify the primary key for table 'attribute'.

[Entity Framework Core 工具引用的.NET CLI](https://docs.microsoft.com/zh-cn/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold)

dotnet ef dbcontext 基架

为生成代码DbContext和数据库的实体类型。 为了使此命令来生成实体类型，数据库表必须具有主键。


# yelp_db


1. 操作为以下数据表增加组件id
原因：
原表没有主键。只有表包含主键，EF Core 才能执行反向工程，DataFirst 生成代码
表：
attribute、checkin、elite_years、friend、hours、tip
id字段

id    varchar  36   0   不为NULL  主键
```sql
SELECT COUNT(user_id) FROM friend WHERE ISNULL(id);

UPDATE friend SET id = UUID()  WHERE ISNULL(id) LIMIT 10000000;




```



# mysql

## issuse

执行更改是锁总数溢出

[mysql [Err] 1206 - The total number of locks exceeds the lock table size](https://blog.csdn.net/github_36326955/article/details/54970808)

原因：
InnoDB表执行大批量数据的更新，插入，删除操作时会出现这个问题，需要调整InnoDB全局的innodb_buffer_pool_size的值来解决这个问题，并且重启mysql服务。

进入mysql命令
show variables like "%_buffer%";(不要忘记带;号，没有;号表示一条语句没有结束)

默认的innodb_buffer_pool_size=8M

显示的格式是 1M*1024*1024,设置的时候也要这样设置，例如

修改 innodb_buffer_pool_size的值为3G