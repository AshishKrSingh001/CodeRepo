<?php
    $connect = mysqli_connect("localhost", "root", "", "hues");
    $record_per_page = 6;
    $page = '';
    if(isset($_GET["page"]))
    {
        $page = $_GET["page"];
    }
    else
    {
        $page = 1;
    }

    $start_from = ($page-1)*$record_per_page;

    $query = "SELECT * FROM hues where category='Hollywood' order by id DESC LIMIT $start_from, $record_per_page";
    $result = mysqli_query($connect, $query);

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Hollywood</title>
</head>
<body>
    <div class="header"><?php include("head.php"); ?></div>
    <div class="main">
            <div class="row">
                <?php while($row = mysqli_fetch_array($result)){?>
                <div class="col">
                    <div class="card">
                    <a href="details.php?dl=<?php echo $row['id'];?>"><img src="<?php echo $row['logo']; ?>" alt="alt.jpg"></a>
                        <a href="details.php?dl=<?php echo $row['id'];?>"><div align="center" class="card_body">
                            <h4><?php echo "Download<br>" . ucwords($row['name']) . "  (" . $row['years'] . ")<br>" . $row['category'] . " Movies<br>{" . ucwords($row['language']) . "} [" .  $row['quality'] . "]"; ?></h4>
                        </div></a>
                    </div>
                </div>
                <?php
                }?>
            </div>
        <div class="php" align="center">
            <?php
                $page_query = "SELECT * FROM hues where category='Hollywood' ORDER BY id DESC";
                $page_result = mysqli_query($connect, $page_query);
                $total_records = mysqli_num_rows($page_result);
                $total_pages = ceil($total_records/$record_per_page);
                $start_loop = $page;
                $difference = $total_pages - $page;
                if($difference <= 3)
                {
                    $start_loop = $total_pages - 3;
                    if($start_loop<1)
                    {
                        $start_loop=1;
                    }
                }
                $end_loop = $start_loop + 2;
                if($end_loop>$total_pages)
                {
                    $end_loop = $start_loop + 1;
                    if($end_loop>$total_pages)
                    {
                        $end_loop = $start_loop;
                    }
                }
                if($page > 1)
                {
                    echo "<a class='a' href='holly.php?page=1'>First</a>";
                    echo "<a class='a' href='holly.php?page=".($page - 1)."'>Previous</a>";
                }
                for($i=$start_loop; $i<=$end_loop; $i++)
                {     
                    echo "<a class='a' href='holly.php?page=".$i."'>".$i."</a>";
                }
                if($page < $end_loop)
                {
                    echo "<a class='a' href='holly.php?page=".($page + 1)."'>Next</a>";
                    echo "<a class='a' href='holly.php?page=".$total_pages."'>Last</a>";
                }
            ?>
        </div>
    </div>
    <div class="footer"><?php include("foot.php"); ?></div>
</body>
</html>

