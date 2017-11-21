use strict;
use warnings;
use Time::HiRes qw( time );

my $foo;
my $maximum;
my $numbertotest;
$maximum = 100000;

my $start = time();


for ($numbertotest = 2; $numbertotest <= $maximum; $numbertotest++)
{
    for ($foo = $numbertotest / 2; $foo >= 2; $foo--)
    {
        if ($numbertotest % $foo == 0)
        {
            last;
        }

    }
}
my $end = time();
printf("%.2f\n", $end - $start);
