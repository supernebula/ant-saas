
[ABP�����ŵ���ͨ��2����aspnet-zero-core ʹ��MySql���ݿ�](https://www.cnblogs.com/stulzq/p/7242581.html)

[���mysql��������ʱ����Incorrect string value: '\xF0\x9F...' for column 'name' at row 1���쳣](https://blog.csdn.net/azhegps/article/details/71480633)

���Ѿ����õı�Ҳת����utf8mb4

���alter table TABLE_NAME convert to character set utf8mb4 collate utf8mb4_bin; ����TABLE_NAME�滻����ı�����



# Issuse

1. ���ݱ�û���������޷��������򹤳�������ʵ����

Scaffold-DbContext "server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Scaffold-DbContext "server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;" Pomelo.EntityFrameworkCore.MySql -OutputDir Models



Unable to identify the primary key for table 'attribute'.

[Entity Framework Core �������õ�.NET CLI](https://docs.microsoft.com/zh-cn/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold)

dotnet ef dbcontext ����

Ϊ���ɴ���DbContext�����ݿ��ʵ�����͡� Ϊ��ʹ������������ʵ�����ͣ����ݿ���������������


# yelp_db


1. ����Ϊ�������ݱ��������id
ԭ��
ԭ��û��������ֻ�б�����������EF Core ����ִ�з��򹤳̣�DataFirst ���ɴ���
����
attribute��checkin��elite_years��friend��hours��tip
id�ֶ�

id    varchar  36   0   ��ΪNULL  ����
```sql
SELECT COUNT(user_id) FROM friend WHERE ISNULL(id);

UPDATE friend SET id = UUID()  WHERE ISNULL(id) LIMIT 10000000;




```



# mysql

## issuse

ִ�и��������������

[mysql [Err] 1206 - The total number of locks exceeds the lock table size](https://blog.csdn.net/github_36326955/article/details/54970808)

ԭ��
InnoDB��ִ�д��������ݵĸ��£����룬ɾ������ʱ�����������⣬��Ҫ����InnoDBȫ�ֵ�innodb_buffer_pool_size��ֵ�����������⣬��������mysql����

����mysql����
show variables like "%_buffer%";(��Ҫ���Ǵ�;�ţ�û��;�ű�ʾһ�����û�н���)

Ĭ�ϵ�innodb_buffer_pool_size=8M

��ʾ�ĸ�ʽ�� 1M*1024*1024,���õ�ʱ��ҲҪ�������ã�����

�޸� innodb_buffer_pool_size��ֵΪ3G