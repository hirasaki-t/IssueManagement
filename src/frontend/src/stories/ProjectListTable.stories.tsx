import { Meta, Story } from "@storybook/react/types-6-0";
import ProjectListTable from "../components/ProjectListTable";

export default {
    title: "components/ProjectListTable",
    components: ProjectListTable,
} as Meta;

const Template: Story = () => <ProjectListTable />;

export const Default = Template.bind({});